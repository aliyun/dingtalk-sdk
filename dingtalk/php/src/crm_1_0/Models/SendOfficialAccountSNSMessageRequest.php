<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail;
use AlibabaCloud\Tea\Model;

class SendOfficialAccountSNSMessageRequest extends Model
{
    /**
     * @description 消息详情
     *
     * @var detail
     */
    public $detail;

    /**
     * @description API调用标识，可选参数
     *
     * @var string
     */
    public $bizId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var string
     */
    public $bindingToken;

    /**
     * @var int
     */
    public $dingUid;

    /**
     * @var int
     */
    public $dingOpenAppOrgId;
    protected $_name = [
        'detail'             => 'detail',
        'bizId'              => 'bizId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingClientId'       => 'dingClientId',
        'bindingToken'       => 'bindingToken',
        'dingUid'            => 'dingUid',
        'dingOpenAppOrgId'   => 'dingOpenAppOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detail) {
            $res['detail'] = null !== $this->detail ? $this->detail->toMap() : null;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->bindingToken) {
            $res['bindingToken'] = $this->bindingToken;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }
        if (null !== $this->dingOpenAppOrgId) {
            $res['dingOpenAppOrgId'] = $this->dingOpenAppOrgId;
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
        if (isset($map['detail'])) {
            $model->detail = detail::fromMap($map['detail']);
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['bindingToken'])) {
            $model->bindingToken = $map['bindingToken'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }
        if (isset($map['dingOpenAppOrgId'])) {
            $model->dingOpenAppOrgId = $map['dingOpenAppOrgId'];
        }

        return $model;
    }
}
