<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail;
use AlibabaCloud\Tea\Model;

class SendOfficialAccountSNSMessageRequest extends Model
{
    /**
     * @var string
     */
    public $bindingToken;

    /**
     * @description API调用标识，可选参数
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 消息详情
     *
     * @var detail
     */
    public $detail;
    protected $_name = [
        'bindingToken' => 'bindingToken',
        'bizId'        => 'bizId',
        'detail'       => 'detail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingToken) {
            $res['bindingToken'] = $this->bindingToken;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->detail) {
            $res['detail'] = null !== $this->detail ? $this->detail->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendOfficialAccountSNSMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingToken'])) {
            $model->bindingToken = $map['bindingToken'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['detail'])) {
            $model->detail = detail::fromMap($map['detail']);
        }

        return $model;
    }
}
