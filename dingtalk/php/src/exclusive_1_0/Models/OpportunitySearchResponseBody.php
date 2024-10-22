<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpportunitySearchResponseBody extends Model
{
    /**
     * @var bool
     */
    public $opportunityExist;
    protected $_name = [
        'opportunityExist' => 'opportunityExist',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opportunityExist) {
            $res['opportunityExist'] = $this->opportunityExist;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpportunitySearchResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opportunityExist'])) {
            $model->opportunityExist = $map['opportunityExist'];
        }

        return $model;
    }
}
