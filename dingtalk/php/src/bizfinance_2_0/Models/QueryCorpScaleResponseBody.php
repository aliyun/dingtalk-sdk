<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCorpScaleResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $corpScaleMap;
    protected $_name = [
        'corpScaleMap' => 'corpScaleMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpScaleMap) {
            $res['corpScaleMap'] = $this->corpScaleMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCorpScaleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpScaleMap'])) {
            $model->corpScaleMap = $map['corpScaleMap'];
        }

        return $model;
    }
}
