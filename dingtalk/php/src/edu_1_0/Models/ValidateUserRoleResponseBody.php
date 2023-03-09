<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ValidateUserRoleResponseBody extends Model
{
    /**
     * @description 是否是家长身份。
     * true表示是家长，false表示不是家长。
     * @var bool
     */
    public $matchParentIdentity;

    /**
     * @description 是否为老师身份。
     * true表示是老师，false表示不是老师。
     * @var bool
     */
    public $matchTeacherIdentity;
    protected $_name = [
        'matchParentIdentity'  => 'matchParentIdentity',
        'matchTeacherIdentity' => 'matchTeacherIdentity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->matchParentIdentity) {
            $res['matchParentIdentity'] = $this->matchParentIdentity;
        }
        if (null !== $this->matchTeacherIdentity) {
            $res['matchTeacherIdentity'] = $this->matchTeacherIdentity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ValidateUserRoleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['matchParentIdentity'])) {
            $model->matchParentIdentity = $map['matchParentIdentity'];
        }
        if (isset($map['matchTeacherIdentity'])) {
            $model->matchTeacherIdentity = $map['matchTeacherIdentity'];
        }

        return $model;
    }
}
