﻿using ICanPay.Wechatpay.Domain;
using ICanPay.Wechatpay.Response;

namespace ICanPay.Wechatpay.Request
{
    public class RefundQueryRequest : BaseRequest<RefundQueryModel, RefundQueryResponse>
    {
        public RefundQueryRequest()
        {
            RequestUrl = "/pay/refundquery";
        }

        internal override void Execute(Merchant merchant)
        {
            GatewayData.Remove("notify_url");
        }
    }
}
