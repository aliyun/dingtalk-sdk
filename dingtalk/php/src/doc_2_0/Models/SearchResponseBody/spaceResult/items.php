<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items\iconVO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items\userLastOperation;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description 知识库图标。
     *
     * @var iconVO
     */
    public $iconVO;

    /**
     * @description 知识库名称，如果命中了关键词，会带有高亮。
     *
     * @var string
     */
    public $name;

    /**
     * @description 知识库原始名称，不带高亮。
     *
     * @var string
     */
    public $originName;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 知识库访问url。
     *
     * @var string
     */
    public $url;

    /**
     * @description 用户最后一次操作信息。
     *
     * @var userLastOperation
     */
    public $userLastOperation;
    protected $_name = [
        'iconVO'            => 'iconVO',
        'name'              => 'name',
        'originName'        => 'originName',
        'spaceId'           => 'spaceId',
        'url'               => 'url',
        'userLastOperation' => 'userLastOperation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iconVO) {
            $res['iconVO'] = null !== $this->iconVO ? $this->iconVO->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originName) {
            $res['originName'] = $this->originName;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->userLastOperation) {
            $res['userLastOperation'] = null !== $this->userLastOperation ? $this->userLastOperation->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['iconVO'])) {
            $model->iconVO = iconVO::fromMap($map['iconVO']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originName'])) {
            $model->originName = $map['originName'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['userLastOperation'])) {
            $model->userLastOperation = userLastOperation::fromMap($map['userLastOperation']);
        }

        return $model;
    }
}
