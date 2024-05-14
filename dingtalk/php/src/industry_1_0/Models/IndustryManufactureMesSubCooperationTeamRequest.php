<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\extendData;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\groupPlugins;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\leaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\members;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesSubCooperationTeamRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @example libai
     *
     * @var string
     */
    public $appKey;

    /**
     * @description This parameter is required.
     *
     * @example outTeam
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @var string[]
     */
    public $events;

    /**
     * @var extendData[]
     */
    public $extendData;

    /**
     * @var groupPlugins[]
     */
    public $groupPlugins;

    /**
     * @example SUB_COOPERATION_GROUP
     *
     * @var string
     */
    public $groupType;

    /**
     * @var leaders[]
     */
    public $leaders;

    /**
     * @var members[]
     */
    public $members;

    /**
     * @example 打磨班组
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example dingfsdfs3fsd2234wds
     *
     * @var string
     */
    public $outCorpId;

    /**
     * @var string[]
     */
    public $processIds;

    /**
     * @description This parameter is required.
     *
     * @example d41d8cd98f00b204e9800998ecf8427e
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'       => 'action',
        'appKey'       => 'appKey',
        'baseDataName' => 'baseDataName',
        'events'       => 'events',
        'extendData'   => 'extendData',
        'groupPlugins' => 'groupPlugins',
        'groupType'    => 'groupType',
        'leaders'      => 'leaders',
        'members'      => 'members',
        'name'         => 'name',
        'outCorpId'    => 'outCorpId',
        'processIds'   => 'processIds',
        'uuid'         => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->events) {
            $res['events'] = $this->events;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = [];
            if (null !== $this->extendData && \is_array($this->extendData)) {
                $n = 0;
                foreach ($this->extendData as $item) {
                    $res['extendData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupPlugins) {
            $res['groupPlugins'] = [];
            if (null !== $this->groupPlugins && \is_array($this->groupPlugins)) {
                $n = 0;
                foreach ($this->groupPlugins as $item) {
                    $res['groupPlugins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->leaders) {
            $res['leaders'] = [];
            if (null !== $this->leaders && \is_array($this->leaders)) {
                $n = 0;
                foreach ($this->leaders as $item) {
                    $res['leaders'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outCorpId) {
            $res['outCorpId'] = $this->outCorpId;
        }
        if (null !== $this->processIds) {
            $res['processIds'] = $this->processIds;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesSubCooperationTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['events'])) {
            if (!empty($map['events'])) {
                $model->events = $map['events'];
            }
        }
        if (isset($map['extendData'])) {
            if (!empty($map['extendData'])) {
                $model->extendData = [];
                $n                 = 0;
                foreach ($map['extendData'] as $item) {
                    $model->extendData[$n++] = null !== $item ? extendData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupPlugins'])) {
            if (!empty($map['groupPlugins'])) {
                $model->groupPlugins = [];
                $n                   = 0;
                foreach ($map['groupPlugins'] as $item) {
                    $model->groupPlugins[$n++] = null !== $item ? groupPlugins::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['leaders'])) {
            if (!empty($map['leaders'])) {
                $model->leaders = [];
                $n              = 0;
                foreach ($map['leaders'] as $item) {
                    $model->leaders[$n++] = null !== $item ? leaders::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outCorpId'])) {
            $model->outCorpId = $map['outCorpId'];
        }
        if (isset($map['processIds'])) {
            if (!empty($map['processIds'])) {
                $model->processIds = $map['processIds'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
