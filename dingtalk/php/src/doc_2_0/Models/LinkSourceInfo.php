<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\LinkSourceInfo\iconUrl;
use AlibabaCloud\Tea\Model;

class LinkSourceInfo extends Model
{
    /**
     * @description 快捷方式关联的源文件后缀。
     *
     * @var string
     */
    public $extension;

    /**
     * @description 非通用快捷方式的图标信息。
     *
     * @var iconUrl
     */
    public $iconUrl;

    /**
     * @description 快捷方式关联的源文件ID（空间内唯一）。
     *
     * @var string
     */
    public $id;

    /**
     * @description 快捷方式类型。0-通用快捷方式；1-闪会快捷方式；2-日志快捷方式；3-闪会2.0快捷方式。
     *
     * @var int
     */
    public $linkType;

    /**
     * @description 快捷方式关联的源文件所属空间id。
     *
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'extension' => 'extension',
        'iconUrl'   => 'iconUrl',
        'id'        => 'id',
        'linkType'  => 'linkType',
        'spaceId'   => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = null !== $this->iconUrl ? $this->iconUrl->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->linkType) {
            $res['linkType'] = $this->linkType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LinkSourceInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = iconUrl::fromMap($map['iconUrl']);
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['linkType'])) {
            $model->linkType = $map['linkType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
