<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest\detail;
use AlibabaCloud\Tea\Model;

class BatchSendOfficialAccountOTOMessageRequest extends Model
{
    /**
     * @description 服务窗帐号ID
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 服务窗授权的调用方标识，可空
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
        'accountId' => 'accountId',
        'bizId'     => 'bizId',
        'detail'    => 'detail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
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
     * @return BatchSendOfficialAccountOTOMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
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
