<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumGetFormInstanceRequest extends Model
{
    /**
     * @example SWAPP-dfeacds-example
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description This parameter is required.
     *
     * @example PROC-abcdef-example
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example 951a8-8828-430c-b3e-example
     *
     * @var string
     */
    public $formInstanceId;
    protected $_name = [
        'appUuid'        => 'appUuid',
        'formCode'       => 'formCode',
        'formInstanceId' => 'formInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumGetFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }

        return $model;
    }
}
