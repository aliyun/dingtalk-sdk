<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateConnectorResponseBody;

use AlibabaCloud\Tea\Model;

class item extends Model
{
    /**
     * @example G-CONN-101921B15FE0212B4AF70
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @example xxxx
     *
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
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'dingConnectorId'       => 'dingConnectorId',
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
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
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
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
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
