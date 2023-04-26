<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items\iconVO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items\teamVO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items\userLastOperation;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var iconVO
     */
    public $iconVO;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $originName;

    /**
     * @var string
     */
    public $spaceId;

    /**
     * @var teamVO
     */
    public $teamVO;

    /**
     * @var string
     */
    public $url;

    /**
     * @var userLastOperation
     */
    public $userLastOperation;
    protected $_name = [
        'iconVO'            => 'iconVO',
        'name'              => 'name',
        'originName'        => 'originName',
        'spaceId'           => 'spaceId',
        'teamVO'            => 'teamVO',
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
        if (null !== $this->teamVO) {
            $res['teamVO'] = null !== $this->teamVO ? $this->teamVO->toMap() : null;
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
        if (isset($map['teamVO'])) {
            $model->teamVO = teamVO::fromMap($map['teamVO']);
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
