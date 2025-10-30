<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCorpScaleRequest extends Model
{
    /**
     * @var string[]
     */
    public $corpNames;
    protected $_name = [
        'corpNames' => 'corpNames',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpNames) {
            $res['corpNames'] = $this->corpNames;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCorpScaleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpNames'])) {
            if (!empty($map['corpNames'])) {
                $model->corpNames = $map['corpNames'];
            }
        }

        return $model;
    }
}
