<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalProgressDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $created;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $creator;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $htmlContent;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $modifier;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $progressId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $updated;
    protected $_name = [
        'created'     => 'created',
        'creator'     => 'creator',
        'htmlContent' => 'htmlContent',
        'modifier'    => 'modifier',
        'progressId'  => 'progressId',
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
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->htmlContent) {
            $res['htmlContent'] = $this->htmlContent;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = null !== $this->modifier ? $this->modifier->toMap() : null;
        }
        if (null !== $this->progressId) {
            $res['progressId'] = $this->progressId;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalProgressDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creator'])) {
            $model->creator = OpenAgoalUserDTO::fromMap($map['creator']);
        }
        if (isset($map['htmlContent'])) {
            $model->htmlContent = $map['htmlContent'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = OpenAgoalUserDTO::fromMap($map['modifier']);
        }
        if (isset($map['progressId'])) {
            $model->progressId = $map['progressId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
