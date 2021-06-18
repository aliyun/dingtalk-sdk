<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdResponseBody;

use AlibabaCloud\Tea\Model;

class empList extends Model
{
    /**
     * @description dingId
     *
     * @var string
     */
    public $dingId;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionid;

    /**
     * @description name
     *
     * @var string
     */
    public $name;

    /**
     * @description nick
     *
     * @var string
     */
    public $nick;

    /**
     * @description userid
     *
     * @var string
     */
    public $userid;

    /**
     * @description orgId
     *
     * @var int
     */
    public $orgId;

    /**
     * @description avatar
     *
     * @var string
     */
    public $avatar;

    /**
     * @description deptIdList
     *
     * @var int[]
     */
    public $deptIdList;

    /**
     * @var string
     */
    public $position;
    protected $_name = [
        'dingId'     => 'dingId',
        'unionid'    => 'unionid',
        'name'       => 'name',
        'nick'       => 'nick',
        'userid'     => 'userid',
        'orgId'      => 'orgId',
        'avatar'     => 'avatar',
        'deptIdList' => 'dept_id_list',
        'position'   => 'position',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingId) {
            $res['dingId'] = $this->dingId;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->deptIdList) {
            $res['dept_id_list'] = $this->deptIdList;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return empList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingId'])) {
            $model->dingId = $map['dingId'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['dept_id_list'])) {
            if (!empty($map['dept_id_list'])) {
                $model->deptIdList = $map['dept_id_list'];
            }
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }

        return $model;
    }
}
