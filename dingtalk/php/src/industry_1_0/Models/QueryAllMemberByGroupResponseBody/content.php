<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0001
     *
     * @var string
     */
    public $jobNum;

    /**
     * @description This parameter is required.
     *
     * @example u0398812938821
     *
     * @var string
     */
    public $uid;

    /**
     * @description This parameter is required.
     *
     * @example 用户名称
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'jobNum' => 'jobNum',
        'uid' => 'uid',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobNum) {
            $res['jobNum'] = $this->jobNum;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobNum'])) {
            $model->jobNum = $map['jobNum'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
