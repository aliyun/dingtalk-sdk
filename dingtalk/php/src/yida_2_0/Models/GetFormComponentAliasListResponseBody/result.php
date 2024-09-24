<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormComponentAliasListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $alias;

    /**
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'alias'   => 'alias',
        'fieldId' => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alias) {
            $res['alias'] = $this->alias;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alias'])) {
            $model->alias = $map['alias'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
