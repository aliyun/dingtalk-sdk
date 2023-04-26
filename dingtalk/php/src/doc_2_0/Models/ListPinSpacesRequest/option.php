<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example true
     *
     * @var bool
     */
    public $withSpaceCreatorInfo;

    /**
     * @example true
     *
     * @var bool
     */
    public $withSpaceModifierInfo;

    /**
     * @example true
     *
     * @var bool
     */
    public $withSpacePermissionRole;

    /**
     * @example true
     *
     * @var bool
     */
    public $withTeamDetail;
    protected $_name = [
        'maxResults'              => 'maxResults',
        'nextToken'               => 'nextToken',
        'withSpaceCreatorInfo'    => 'withSpaceCreatorInfo',
        'withSpaceModifierInfo'   => 'withSpaceModifierInfo',
        'withSpacePermissionRole' => 'withSpacePermissionRole',
        'withTeamDetail'          => 'withTeamDetail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->withSpaceCreatorInfo) {
            $res['withSpaceCreatorInfo'] = $this->withSpaceCreatorInfo;
        }
        if (null !== $this->withSpaceModifierInfo) {
            $res['withSpaceModifierInfo'] = $this->withSpaceModifierInfo;
        }
        if (null !== $this->withSpacePermissionRole) {
            $res['withSpacePermissionRole'] = $this->withSpacePermissionRole;
        }
        if (null !== $this->withTeamDetail) {
            $res['withTeamDetail'] = $this->withTeamDetail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['withSpaceCreatorInfo'])) {
            $model->withSpaceCreatorInfo = $map['withSpaceCreatorInfo'];
        }
        if (isset($map['withSpaceModifierInfo'])) {
            $model->withSpaceModifierInfo = $map['withSpaceModifierInfo'];
        }
        if (isset($map['withSpacePermissionRole'])) {
            $model->withSpacePermissionRole = $map['withSpacePermissionRole'];
        }
        if (isset($map['withTeamDetail'])) {
            $model->withTeamDetail = $map['withTeamDetail'];
        }

        return $model;
    }
}
