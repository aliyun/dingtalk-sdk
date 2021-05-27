<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchTeachersRequest extends Model
{
    /**
     * @var string
     */
    public $nameKeyword;
    protected $_name = [
        'nameKeyword' => 'nameKeyword',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nameKeyword) {
            $res['nameKeyword'] = $this->nameKeyword;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchTeachersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nameKeyword'])) {
            $model->nameKeyword = $map['nameKeyword'];
        }

        return $model;
    }
}
