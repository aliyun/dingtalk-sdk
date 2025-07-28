<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetTeamResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetTeamResponseBody\team\icon;
use AlibabaCloud\Tea\Model;

class team extends Model
{
    /**
     * @example corp_id
     *
     * @var string
     */
    public $corpId;

    /**
     * @example team_cover
     *
     * @var string
     */
    public $cover;

    /**
     * @example team_create_time
     *
     * @var string
     */
    public $createTime;

    /**
     * @example team_creator_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example team_description
     *
     * @var string
     */
    public $description;

    /**
     * @var icon
     */
    public $icon;

    /**
     * @example team_modified_time
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @example team_modifier_id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example team_name
     *
     * @var string
     */
    public $name;

    /**
     * @example team_id
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'corpId' => 'corpId',
        'cover' => 'cover',
        'createTime' => 'createTime',
        'creatorId' => 'creatorId',
        'description' => 'description',
        'icon' => 'icon',
        'modifiedTime' => 'modifiedTime',
        'modifierId' => 'modifierId',
        'name' => 'name',
        'teamId' => 'teamId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = null !== $this->icon ? $this->icon->toMap() : null;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return team
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = icon::fromMap($map['icon']);
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
