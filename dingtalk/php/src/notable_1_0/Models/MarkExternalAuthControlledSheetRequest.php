<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class MarkExternalAuthControlledSheetRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $externalAuthType;

    /**
     * @var string
     */
    public $externalConfig;

    /**
     * @var string
     */
    public $clientToken;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'externalAuthType' => 'externalAuthType',
        'externalConfig' => 'externalConfig',
        'clientToken' => 'clientToken',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->externalAuthType) {
            $res['externalAuthType'] = $this->externalAuthType;
        }
        if (null !== $this->externalConfig) {
            $res['externalConfig'] = $this->externalConfig;
        }
        if (null !== $this->clientToken) {
            $res['clientToken'] = $this->clientToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MarkExternalAuthControlledSheetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['externalAuthType'])) {
            $model->externalAuthType = $map['externalAuthType'];
        }
        if (isset($map['externalConfig'])) {
            $model->externalConfig = $map['externalConfig'];
        }
        if (isset($map['clientToken'])) {
            $model->clientToken = $map['clientToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
