<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoResponseBody\result\depts;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var depts[]
     */
    public $depts;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $intake;

    /**
     * @var int
     */
    public $inviteId;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $outtake;

    /**
     * @var string
     */
    public $studentNumber;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'address'       => 'address',
        'avatar'        => 'avatar',
        'corpId'        => 'corpId',
        'depts'         => 'depts',
        'email'         => 'email',
        'intake'        => 'intake',
        'inviteId'      => 'inviteId',
        'mobile'        => 'mobile',
        'name'          => 'name',
        'outtake'       => 'outtake',
        'studentNumber' => 'studentNumber',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->depts) {
            $res['depts'] = [];
            if (null !== $this->depts && \is_array($this->depts)) {
                $n = 0;
                foreach ($this->depts as $item) {
                    $res['depts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->intake) {
            $res['intake'] = $this->intake;
        }
        if (null !== $this->inviteId) {
            $res['inviteId'] = $this->inviteId;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outtake) {
            $res['outtake'] = $this->outtake;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['depts'])) {
            if (!empty($map['depts'])) {
                $model->depts = [];
                $n            = 0;
                foreach ($map['depts'] as $item) {
                    $model->depts[$n++] = null !== $item ? depts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['intake'])) {
            $model->intake = $map['intake'];
        }
        if (isset($map['inviteId'])) {
            $model->inviteId = $map['inviteId'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outtake'])) {
            $model->outtake = $map['outtake'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
