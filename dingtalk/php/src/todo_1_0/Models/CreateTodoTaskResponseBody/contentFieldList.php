<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponseBody;

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
     * @description 字段值
     *
     * @var string
     */
    public $fieldValue;

    /**
     * @description 字段内容链接
     *
     * @var string
     */
    public $fieldLink;
    protected $_name = [
        'fieldKey'   => 'fieldKey',
        'fieldValue' => 'fieldValue',
        'fieldLink'  => 'fieldLink',
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
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }
        if (null !== $this->fieldLink) {
            $res['fieldLink'] = $this->fieldLink;
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
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }
        if (isset($map['fieldLink'])) {
            $model->fieldLink = $map['fieldLink'];
        }

        return $model;
    }
}
