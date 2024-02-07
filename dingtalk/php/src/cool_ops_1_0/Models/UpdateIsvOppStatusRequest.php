<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\UpdateIsvOppStatusRequest\isvOpportunityStatusList;
use AlibabaCloud\Tea\Model;

class UpdateIsvOppStatusRequest extends Model
{
    /**
     * @var isvOpportunityStatusList[]
     */
    public $isvOpportunityStatusList;
    protected $_name = [
        'isvOpportunityStatusList' => 'isvOpportunityStatusList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvOpportunityStatusList) {
            $res['isvOpportunityStatusList'] = [];
            if (null !== $this->isvOpportunityStatusList && \is_array($this->isvOpportunityStatusList)) {
                $n = 0;
                foreach ($this->isvOpportunityStatusList as $item) {
                    $res['isvOpportunityStatusList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateIsvOppStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvOpportunityStatusList'])) {
            if (!empty($map['isvOpportunityStatusList'])) {
                $model->isvOpportunityStatusList = [];
                $n                               = 0;
                foreach ($map['isvOpportunityStatusList'] as $item) {
                    $model->isvOpportunityStatusList[$n++] = null !== $item ? isvOpportunityStatusList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
