<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建者用户ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 任务分组名称。
     *
     * @var string
     */
    public $description;

    /**
     * @description 项目ID。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 任务分组ID。
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 任务分组名称。
     *
     * @var string
     */
    public $title;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'created'     => 'created',
        'creatorId'   => 'creatorId',
        'description' => 'description',
        'projectId'   => 'projectId',
        'taskId'      => 'taskId',
        'title'       => 'title',
        'updated'     => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
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
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
