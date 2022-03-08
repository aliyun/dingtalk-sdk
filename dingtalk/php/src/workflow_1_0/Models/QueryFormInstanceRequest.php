<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFormInstanceRequest extends Model
{
    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 表单模板Code
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单实例id
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
     * @return QueryFormInstanceRequest
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
