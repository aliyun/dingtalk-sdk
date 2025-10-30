<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\TiktokWebhookProcessResponseBody\omniChannelTiktokWebhookRsp;
use AlibabaCloud\Tea\Model;

class TiktokWebhookProcessResponseBody extends Model
{
    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var omniChannelTiktokWebhookRsp
     */
    public $omniChannelTiktokWebhookRsp;

    /**
     * @var string
     */
    public $success;
    protected $_name = [
        'errorCode' => 'errorCode',
        'errorMsg' => 'errorMsg',
        'omniChannelTiktokWebhookRsp' => 'omniChannelTiktokWebhookRsp',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->omniChannelTiktokWebhookRsp) {
            $res['omniChannelTiktokWebhookRsp'] = null !== $this->omniChannelTiktokWebhookRsp ? $this->omniChannelTiktokWebhookRsp->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TiktokWebhookProcessResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['omniChannelTiktokWebhookRsp'])) {
            $model->omniChannelTiktokWebhookRsp = omniChannelTiktokWebhookRsp::fromMap($map['omniChannelTiktokWebhookRsp']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
