<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenProgressDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 48383883
     *
     * @var int
     */
    public $created;

    /**
     * @description This parameter is required.
     *
     * @var OpenUserDTO
     */
    public $creator;

    /**
     * @description This parameter is required.
     *
     * @example 我的目标
     *
     * @var string
     */
    public $htmlContent;

    /**
     * @description This parameter is required.
     *
     * @example 11
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @var OpenUserDTO
     */
    public $modifier;

    /**
     * @description This parameter is required.
     *
     * @example 48383883
     *
     * @var int
     */
    public $updated;
    protected $_name = [
        'created' => 'created',
        'creator' => 'creator',
        'htmlContent' => 'htmlContent',
        'id' => 'id',
        'modifier' => 'modifier',
        'updated' => 'updated',
    ];

    public function validate() {}

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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = null !== $this->modifier ? $this->modifier->toMap() : null;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenProgressDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creator'])) {
            $model->creator = OpenUserDTO::fromMap($map['creator']);
        }
        if (isset($map['htmlContent'])) {
            $model->htmlContent = $map['htmlContent'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = OpenUserDTO::fromMap($map['modifier']);
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
