<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryOpportunityTagRequest extends Model
{
    /**
     * @var string[]
     */
    public $corpIdList;
    protected $_name = [
        'corpIdList' => 'corpIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpIdList) {
            $res['corpIdList'] = $this->corpIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryOpportunityTagRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpIdList'])) {
            if (!empty($map['corpIdList'])) {
                $model->corpIdList = $map['corpIdList'];
            }
        }

        return $model;
    }
}
