<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields;

use AlibabaCloud\Tea\Model;

class rollUpSummaryFields extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $aggregator;
    protected $_name = [
        'name'       => 'name',
        'aggregator' => 'aggregator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->aggregator) {
            $res['aggregator'] = $this->aggregator;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['aggregator'])) {
            $model->aggregator = $map['aggregator'];
        }

        return $model;
    }
}
