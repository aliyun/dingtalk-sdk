<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdResponseBody;

use AlibabaCloud\Tea\Model;

class empList extends Model
{
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
     * @description dingId
     *
     * @var string
     */
    public $dingId;

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
     * @description orgId
     *
     * @var int
     */
    public $orgId;

    /**
     * @var string
     */
    public $position;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionid;

    /**
     * @description userid
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'avatar'     => 'avatar',
        'deptIdList' => 'dept_id_list',
        'dingId'     => 'dingId',
        'name'       => 'name',
        'nick'       => 'nick',
        'orgId'      => 'orgId',
        'position'   => 'position',
        'unionid'    => 'unionid',
        'userid'     => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->deptIdList) {
            $res['dept_id_list'] = $this->deptIdList;
        }
        if (null !== $this->dingId) {
            $res['dingId'] = $this->dingId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
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
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['dept_id_list'])) {
            if (!empty($map['dept_id_list'])) {
                $model->deptIdList = $map['dept_id_list'];
            }
        }
        if (isset($map['dingId'])) {
            $model->dingId = $map['dingId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
