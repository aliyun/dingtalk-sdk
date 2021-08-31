<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkspaceDocRequest extends Model
{
    /**
     * @description 文档名
     *
     * @var string
     */
    public $name;

    /**
     * @description 文档类型
     *
     * @var string
     */
    public $docType;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'name'       => 'name',
        'docType'    => 'docType',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkspaceDocRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
