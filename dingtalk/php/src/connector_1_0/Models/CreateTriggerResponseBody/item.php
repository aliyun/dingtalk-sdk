<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerResponseBody;

use AlibabaCloud\Tea\Model;

class item extends Model
{
    /**
     * @var string
     */
    public $dingConnectorId;

    /**
     * @var string
     */
    public $dingTriggerId;

    /**
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @var string
     */
    public $integratorTriggerId;

    /**
     * @var string
     */
    public $subErrCode;

    /**
     * @var string
     */
    public $subErrMsg;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'dingConnectorId'       => 'dingConnectorId',
        'dingTriggerId'         => 'dingTriggerId',
        'integratorConnectorId' => 'integratorConnectorId',
        'integratorTriggerId'   => 'integratorTriggerId',
        'subErrCode'            => 'subErrCode',
        'subErrMsg'             => 'subErrMsg',
        'success'               => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->dingTriggerId) {
            $res['dingTriggerId'] = $this->dingTriggerId;
        }
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->integratorTriggerId) {
            $res['integratorTriggerId'] = $this->integratorTriggerId;
        }
        if (null !== $this->subErrCode) {
            $res['subErrCode'] = $this->subErrCode;
        }
        if (null !== $this->subErrMsg) {
            $res['subErrMsg'] = $this->subErrMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return item
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['dingTriggerId'])) {
            $model->dingTriggerId = $map['dingTriggerId'];
        }
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['integratorTriggerId'])) {
            $model->integratorTriggerId = $map['integratorTriggerId'];
        }
        if (isset($map['subErrCode'])) {
            $model->subErrCode = $map['subErrCode'];
        }
        if (isset($map['subErrMsg'])) {
            $model->subErrMsg = $map['subErrMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
