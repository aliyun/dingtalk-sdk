<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUserExtendInfoRequest extends Model
{
    /**
     * @description comments
     *
     * @var string
     */
    public $comments;

    /**
     * @description 职称code
     *
     * @var string
     */
    public $jobCode;

    /**
     * @description 工作状态code
     *
     * @var string[]
     */
    public $jobStatusCode;

    /**
     * @description 用户属性code
     *
     * @var string
     */
    public $userProbCode;
    protected $_name = [
        'comments'      => 'comments',
        'jobCode'       => 'jobCode',
        'jobStatusCode' => 'jobStatusCode',
        'userProbCode'  => 'userProbCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comments) {
            $res['comments'] = $this->comments;
        }
        if (null !== $this->jobCode) {
            $res['jobCode'] = $this->jobCode;
        }
        if (null !== $this->jobStatusCode) {
            $res['jobStatusCode'] = $this->jobStatusCode;
        }
        if (null !== $this->userProbCode) {
            $res['userProbCode'] = $this->userProbCode;
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
        if (isset($map['comments'])) {
            $model->comments = $map['comments'];
        }
        if (isset($map['jobCode'])) {
            $model->jobCode = $map['jobCode'];
        }
        if (isset($map['jobStatusCode'])) {
            if (!empty($map['jobStatusCode'])) {
                $model->jobStatusCode = $map['jobStatusCode'];
            }
        }
        if (isset($map['userProbCode'])) {
            $model->userProbCode = $map['userProbCode'];
        }

        return $model;
    }
}
