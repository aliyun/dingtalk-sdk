<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceByIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceByIdResponseBody\originator\name;
use AlibabaCloud\Tea\Model;

class originator extends Model
{
    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $email;

    /**
     * @var name
     */
    public $name;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptName' => 'deptName',
        'email'    => 'email',
        'name'     => 'name',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
