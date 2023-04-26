<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionResponseBody;

use AlibabaCloud\Tea\Model;

class item extends Model
{
    /**
     * @var string
     */
    public $dingActionId;

    /**
     * @var string
     */
    public $dingConnectorId;

    /**
     * @var string
     */
    public $integratorActionId;

    /**
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @var string
     */
    public $subErrCode;

    /**
     * @var string
     */
    public $subErrMsg;

    /**
     * @var string
     */
    public $success;
    protected $_name = [
        'dingActionId'          => 'dingActionId',
        'dingConnectorId'       => 'dingConnectorId',
        'integratorActionId'    => 'integratorActionId',
        'integratorConnectorId' => 'integratorConnectorId',
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
        if (null !== $this->dingActionId) {
            $res['dingActionId'] = $this->dingActionId;
        }
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->integratorActionId) {
            $res['integratorActionId'] = $this->integratorActionId;
        }
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
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
        if (isset($map['dingActionId'])) {
            $model->dingActionId = $map['dingActionId'];
        }
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['integratorActionId'])) {
            $model->integratorActionId = $map['integratorActionId'];
        }
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
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
