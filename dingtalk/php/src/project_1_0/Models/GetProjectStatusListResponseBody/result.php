<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectStatusListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 项目状态内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 项目状态创建人ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 项目状态指标：'normal','risky','urgent'。
     *
     * @var string
     */
    public $degree;

    /**
     * @description 项目状态名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 项目ID。
     *
     * @var string
     */
    public $projectId;
    protected $_name = [
        'content'   => 'content',
        'created'   => 'created',
        'creatorId' => 'creatorId',
        'degree'    => 'degree',
        'name'      => 'name',
        'projectId' => 'projectId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->degree) {
            $res['degree'] = $this->degree;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['degree'])) {
            $model->degree = $map['degree'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }

        return $model;
    }
}
