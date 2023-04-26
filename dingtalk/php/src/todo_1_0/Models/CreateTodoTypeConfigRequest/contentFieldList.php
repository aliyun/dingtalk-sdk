<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigRequest;

use AlibabaCloud\Tea\Model;

class contentFieldList extends Model
{
    /**
     * @var string
     */
    public $fieldKey;

    /**
     * @var string
     */
    public $fieldType;

    /**
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
