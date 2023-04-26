<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointAutoIssueSettingResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $pointAutoNum;

    /**
     * @example true
     *
     * @var bool
     */
    public $pointAutoState;

    /**
     * @example 15
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
