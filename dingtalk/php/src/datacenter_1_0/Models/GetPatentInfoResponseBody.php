<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPatentInfoResponseBody extends Model
{
    /**
     * @example [{"EntName":"企业名称", "PatentType":"专利类型", "PatentName":"专利名", "PatentStatus":"专利状态", "RequestNum":"申请号", "RequestDate":"申请日", "PublicNum":"公开(公告)号", "PublicDate":"公开(公告)日", "InventorList":"发明人", "PatenteeList":"专利权人", "CateNum":"分类号", "PrioNum":"优先权号", "PrioDate":"优先权日", "Agency":"专利代理机构", "Agent":"代理人", "Brief":"简要说明", "MainClaim":"主权项"}]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data'  => 'data',
        'total' => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPatentInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
