<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRangeProtectionResponseBody extends Model
{
    /**
     * @example A1
     *
     * @var string
     */
    public $a1Notation;
    protected $_name = [
        'a1Notation' => 'a1Notation',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRangeProtectionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['a1Notation'])) {
            $model->a1Notation = $map['a1Notation'];
        }

        return $model;
    }
}
