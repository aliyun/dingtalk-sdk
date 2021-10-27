<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFormInstanceRequest extends Model
{
    /**
     * @description 表单实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单模板Code
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;
    protected $_name = [
        'formInstanceId' => 'formInstanceId',
        'formCode'       => 'formCode',
        'appUuid'        => 'appUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }

        return $model;
    }
}
