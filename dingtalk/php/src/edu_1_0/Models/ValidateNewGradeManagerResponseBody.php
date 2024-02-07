<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ValidateNewGradeManagerResponseBody extends Model
{
    /**
     * @var bool
     */
    public $matchRule;
    protected $_name = [
        'matchRule' => 'matchRule',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->matchRule) {
            $res['matchRule'] = $this->matchRule;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ValidateNewGradeManagerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['matchRule'])) {
            $model->matchRule = $map['matchRule'];
        }

        return $model;
    }
}
