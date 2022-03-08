<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields;

use AlibabaCloud\Tea\Model;

class rollUpSummaryFields extends Model
{
    /**
     * @var string
     */
    public $aggregator;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'aggregator' => 'aggregator',
        'name'       => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->aggregator) {
            $res['aggregator'] = $this->aggregator;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rollUpSummaryFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aggregator'])) {
            $model->aggregator = $map['aggregator'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
