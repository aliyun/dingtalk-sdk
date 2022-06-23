<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointAutoIssueSettingResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 企业每月额度自动发放给每个人的数量
     *
     * @var int
     */
    public $pointAutoNum;

    /**
     * @description 企业积分自动发放状态
     *
     * @var bool
     */
    public $pointAutoState;

    /**
     * @description 企业积分自动发放时间 指定的是每月1号或15号
     *
     * @var int
     */
    public $pointAutoTime;
    protected $_name = [
        'pointAutoNum'   => 'pointAutoNum',
        'pointAutoState' => 'pointAutoState',
        'pointAutoTime'  => 'pointAutoTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pointAutoNum) {
            $res['pointAutoNum'] = $this->pointAutoNum;
        }
        if (null !== $this->pointAutoState) {
            $res['pointAutoState'] = $this->pointAutoState;
        }
        if (null !== $this->pointAutoTime) {
            $res['pointAutoTime'] = $this->pointAutoTime;
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
        if (isset($map['pointAutoNum'])) {
            $model->pointAutoNum = $map['pointAutoNum'];
        }
        if (isset($map['pointAutoState'])) {
            $model->pointAutoState = $map['pointAutoState'];
        }
        if (isset($map['pointAutoTime'])) {
            $model->pointAutoTime = $map['pointAutoTime'];
        }

        return $model;
    }
}
