<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 用户Id
     *
     * @var string
     */
    public $uid;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $userName;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNum;
    protected $_name = [
        'uid'      => 'uid',
        'userName' => 'userName',
        'jobNum'   => 'jobNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->jobNum) {
            $res['jobNum'] = $this->jobNum;
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
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['jobNum'])) {
            $model->jobNum = $map['jobNum'];
        }

        return $model;
    }
}
