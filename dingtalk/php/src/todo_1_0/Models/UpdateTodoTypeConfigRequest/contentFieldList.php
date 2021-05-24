<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest;

use AlibabaCloud\Tea\Model;

class contentFieldList extends Model
{
    /**
     * @description 字段唯一标识
     *
     * @var string
     */
    public $fieldKey;

    /**
     * @description 字段类型（取值为：text-文本，url-链接）
     *
     * @var string
     */
    public $fieldType;

    /**
     * @description 字段显示名称(需支持国际化)
     *
     * @var mixed[]
     */
    public $nameI18n;
    protected $_name = [
        'fieldKey'  => 'fieldKey',
        'fieldType' => 'fieldType',
        'nameI18n'  => 'nameI18n',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->nameI18n) {
            $res['nameI18n'] = $this->nameI18n;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contentFieldList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['nameI18n'])) {
            $model->nameI18n = $map['nameI18n'];
        }

        return $model;
    }
}
