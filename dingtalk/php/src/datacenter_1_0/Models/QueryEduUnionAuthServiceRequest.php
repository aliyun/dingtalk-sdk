<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryEduUnionAuthServiceRequest extends Model
{
    /**
     * @var string
     */
    public $ds;
    protected $_name = [
        'ds' => 'ds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ds) {
            $res['ds'] = $this->ds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEduUnionAuthServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ds'])) {
            $model->ds = $map['ds'];
        }

        return $model;
    }
}
