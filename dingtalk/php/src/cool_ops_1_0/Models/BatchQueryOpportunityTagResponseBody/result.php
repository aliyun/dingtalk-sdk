<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagResponseBody\result\opportunityList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var opportunityList[]
     */
    public $opportunityList;
    protected $_name = [
        'opportunityList' => 'opportunityList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opportunityList) {
            $res['opportunityList'] = [];
            if (null !== $this->opportunityList && \is_array($this->opportunityList)) {
                $n = 0;
                foreach ($this->opportunityList as $item) {
                    $res['opportunityList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opportunityList'])) {
            if (!empty($map['opportunityList'])) {
                $model->opportunityList = [];
                $n                      = 0;
                foreach ($map['opportunityList'] as $item) {
                    $model->opportunityList[$n++] = null !== $item ? opportunityList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
