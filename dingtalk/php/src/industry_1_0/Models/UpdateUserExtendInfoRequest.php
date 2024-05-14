<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUserExtendInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 备注, 当jobStatusCode为其他(0)时, 需要通过该字段补充状态
     *
     * @var string
     */
    public $comments;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $jobCode;

    /**
     * @var string[]
     */
    public $jobStatusCode;

    /**
     * @description This parameter is required.
     *
     * @example 1
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
