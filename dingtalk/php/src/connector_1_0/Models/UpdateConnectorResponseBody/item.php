<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorResponseBody;

use AlibabaCloud\Tea\Model;

class item extends Model
{
    /**
     * @description 服务商连接器connectorId
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @description 连接平台connectorId
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 错误码
     *
     * @var string
     */
    public $subErrCode;

    /**
     * @description 错误信息
     *
     * @var string
     */
    public $subErrMsg;
    protected $_name = [
        'integratorConnectorId' => 'integratorConnectorId',
        'dingConnectorId'       => 'dingConnectorId',
        'success'               => 'success',
        'subErrCode'            => 'subErrCode',
        'subErrMsg'             => 'subErrMsg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->subErrCode) {
            $res['subErrCode'] = $this->subErrCode;
        }
        if (null !== $this->subErrMsg) {
            $res['subErrMsg'] = $this->subErrMsg;
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
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['subErrCode'])) {
            $model->subErrCode = $map['subErrCode'];
        }
        if (isset($map['subErrMsg'])) {
            $model->subErrMsg = $map['subErrMsg'];
        }

        return $model;
    }
}
