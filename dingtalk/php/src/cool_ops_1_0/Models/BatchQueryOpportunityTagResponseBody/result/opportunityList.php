<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagResponseBody\result;

use AlibabaCloud\Tea\Model;

class opportunityList extends Model
{
    /**
     * @example 50
     *
     * @var int
     */
    public $activeUserCnt7d;

    /**
     * @example c:近7日活跃
     *
     * @var string
     */
    public $appActiveState;

    /**
     * @example ding939a85cb101e83b0
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2-广场
     *
     * @var string
     */
    public $fstFunnelsourceNameLv1;

    /**
     * @example 2-广场
     *
     * @var string
     */
    public $funnelsourceNameLv1;
    protected $_name = [
        'activeUserCnt7d' => 'activeUserCnt7d',
        'appActiveState' => 'appActiveState',
        'corpId' => 'corpId',
        'fstFunnelsourceNameLv1' => 'fstFunnelsourceNameLv1',
        'funnelsourceNameLv1' => 'funnelsourceNameLv1',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeUserCnt7d) {
            $res['activeUserCnt7d'] = $this->activeUserCnt7d;
        }
        if (null !== $this->appActiveState) {
            $res['appActiveState'] = $this->appActiveState;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->fstFunnelsourceNameLv1) {
            $res['fstFunnelsourceNameLv1'] = $this->fstFunnelsourceNameLv1;
        }
        if (null !== $this->funnelsourceNameLv1) {
            $res['funnelsourceNameLv1'] = $this->funnelsourceNameLv1;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return opportunityList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeUserCnt7d'])) {
            $model->activeUserCnt7d = $map['activeUserCnt7d'];
        }
        if (isset($map['appActiveState'])) {
            $model->appActiveState = $map['appActiveState'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['fstFunnelsourceNameLv1'])) {
            $model->fstFunnelsourceNameLv1 = $map['fstFunnelsourceNameLv1'];
        }
        if (isset($map['funnelsourceNameLv1'])) {
            $model->funnelsourceNameLv1 = $map['funnelsourceNameLv1'];
        }

        return $model;
    }
}
