<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\unionEmpExt;

use AlibabaCloud\Tea\Model;

class unionEmpMapList extends Model
{
    /**
     * @example dingxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 5000
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'corpId' => 'corpId',
        'userid' => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unionEmpMapList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
