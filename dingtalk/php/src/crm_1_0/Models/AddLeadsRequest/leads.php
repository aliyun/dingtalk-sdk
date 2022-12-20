<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddLeadsRequest;

use AlibabaCloud\Tea\Model;

class leads extends Model
{
    /**
     * @description 线索名称。
     *
     * @var string
     */
    public $leadsName;

    /**
     * @description 线索id。
     *
     * @var string
     */
    public $outLeadsId;
    protected $_name = [
        'leadsName'  => 'leadsName',
        'outLeadsId' => 'outLeadsId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leadsName) {
            $res['leadsName'] = $this->leadsName;
        }
        if (null !== $this->outLeadsId) {
            $res['outLeadsId'] = $this->outLeadsId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leads
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leadsName'])) {
            $model->leadsName = $map['leadsName'];
        }
        if (isset($map['outLeadsId'])) {
            $model->outLeadsId = $map['outLeadsId'];
        }

        return $model;
    }
}
