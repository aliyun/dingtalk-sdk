<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $autoStartErrorMsg;

    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var string
     */
    public $initiateUrl;

    /**
     * @var string
     */
    public $signFlowId;

    /**
     * @var string
     */
    public $signFlowStatus;
    protected $_name = [
        'autoStartErrorMsg' => 'autoStartErrorMsg',
        'bizFlowId' => 'bizFlowId',
        'initiateUrl' => 'initiateUrl',
        'signFlowId' => 'signFlowId',
        'signFlowStatus' => 'signFlowStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoStartErrorMsg) {
            $res['autoStartErrorMsg'] = $this->autoStartErrorMsg;
        }
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->initiateUrl) {
            $res['initiateUrl'] = $this->initiateUrl;
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }
        if (null !== $this->signFlowStatus) {
            $res['signFlowStatus'] = $this->signFlowStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoStartErrorMsg'])) {
            $model->autoStartErrorMsg = $map['autoStartErrorMsg'];
        }
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['initiateUrl'])) {
            $model->initiateUrl = $map['initiateUrl'];
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }
        if (isset($map['signFlowStatus'])) {
            $model->signFlowStatus = $map['signFlowStatus'];
        }

        return $model;
    }
}
