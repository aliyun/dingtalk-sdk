<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllResponseBody;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @var string
     */
    public $a1Notation;

    /**
     * @var mixed[][]
     */
    public $values;
    protected $_name = [
        'a1Notation' => 'a1Notation',
        'values'     => 'values',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->a1Notation) {
            $res['a1Notation'] = $this->a1Notation;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return value
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['a1Notation'])) {
            $model->a1Notation = $map['a1Notation'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }

        return $model;
    }
}
