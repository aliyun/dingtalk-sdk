<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUserExtendInfoRequest extends Model
{
    /**
     * @description 职称code
     *
     * @var string
     */
    public $jobCode;

    /**
     * @description 用户属性code
     *
     * @var string
     */
    public $userProbCode;

    /**
     * @description 工作状态code
     *
     * @var string[]
     */
    public $jobStatusCode;

    /**
     * @description comments
     *
     * @var string
     */
    public $comments;
    protected $_name = [
        'jobCode'       => 'jobCode',
        'userProbCode'  => 'userProbCode',
        'jobStatusCode' => 'jobStatusCode',
        'comments'      => 'comments',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobCode) {
            $res['jobCode'] = $this->jobCode;
        }
        if (null !== $this->userProbCode) {
            $res['userProbCode'] = $this->userProbCode;
        }
        if (null !== $this->jobStatusCode) {
            $res['jobStatusCode'] = $this->jobStatusCode;
        }
        if (null !== $this->comments) {
            $res['comments'] = $this->comments;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateUserExtendInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobCode'])) {
            $model->jobCode = $map['jobCode'];
        }
        if (isset($map['userProbCode'])) {
            $model->userProbCode = $map['userProbCode'];
        }
        if (isset($map['jobStatusCode'])) {
            if (!empty($map['jobStatusCode'])) {
                $model->jobStatusCode = $map['jobStatusCode'];
            }
        }
        if (isset($map['comments'])) {
            $model->comments = $map['comments'];
        }

        return $model;
    }
}
