<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class hideSceneConfig extends Model
{
    /**
     * @var bool
     */
    public $active;

    /**
     * @var bool
     */
    public $chatboxSubtitle;

    /**
     * @var bool
     */
    public $nodeList;

    /**
     * @var bool
     */
    public $profile;

    /**
     * @var bool
     */
    public $search;
    protected $_name = [
        'active'          => 'active',
        'chatboxSubtitle' => 'chatboxSubtitle',
        'nodeList'        => 'nodeList',
        'profile'         => 'profile',
        'search'          => 'search',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->chatboxSubtitle) {
            $res['chatboxSubtitle'] = $this->chatboxSubtitle;
        }
        if (null !== $this->nodeList) {
            $res['nodeList'] = $this->nodeList;
        }
        if (null !== $this->profile) {
            $res['profile'] = $this->profile;
        }
        if (null !== $this->search) {
            $res['search'] = $this->search;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return hideSceneConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['chatboxSubtitle'])) {
            $model->chatboxSubtitle = $map['chatboxSubtitle'];
        }
        if (isset($map['nodeList'])) {
            $model->nodeList = $map['nodeList'];
        }
        if (isset($map['profile'])) {
            $model->profile = $map['profile'];
        }
        if (isset($map['search'])) {
            $model->search = $map['search'];
        }

        return $model;
    }
}
