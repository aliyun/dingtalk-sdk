<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCorpScaleShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $corpNamesShrink;
    protected $_name = [
        'corpNamesShrink' => 'corpNames',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpNamesShrink) {
            $res['corpNames'] = $this->corpNamesShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCorpScaleShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpNames'])) {
            $model->corpNamesShrink = $map['corpNames'];
        }

        return $model;
    }
}
