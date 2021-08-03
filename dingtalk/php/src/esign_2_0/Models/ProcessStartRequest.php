<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest\ccs;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest\files;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest\participants;
use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest\sourceInfo;
use AlibabaCloud\Tea\Model;

class ProcessStartRequest extends Model
{
    /**
     * @description 是否跳过发起签署页直接发起
     *
     * @var string
     */
    public $autoStart;

    /**
     * @description 发起方userId
     *
     * @var string
     */
    public $initiatorUserId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 任务名称（默认文件名）
     *
     * @var string
     */
    public $taskName;

    /**
     * @description 回跳地址
     *
     * @var string
     */
    public $redirectUrl;

    /**
     * @description 文件列表
     *
     * @var files[]
     */
    public $files;

    /**
     * @description 参与方列表
     *
     * @var participants[]
     */
    public $participants;

    /**
     * @description 抄送人列表
     *
     * @var ccs[]
     */
    public $ccs;

    /**
     * @description 来源信息(目前支持传入审批信息和跳转地址)
     *
     * @var sourceInfo
     */
    public $sourceInfo;
    protected $_name = [
        'autoStart'       => 'autoStart',
        'initiatorUserId' => 'initiatorUserId',
        'dingCorpId'      => 'dingCorpId',
        'taskName'        => 'taskName',
        'redirectUrl'     => 'redirectUrl',
        'files'           => 'files',
        'participants'    => 'participants',
        'ccs'             => 'ccs',
        'sourceInfo'      => 'sourceInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoStart) {
            $res['autoStart'] = $this->autoStart;
        }
        if (null !== $this->initiatorUserId) {
            $res['initiatorUserId'] = $this->initiatorUserId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->redirectUrl) {
            $res['redirectUrl'] = $this->redirectUrl;
        }
        if (null !== $this->files) {
            $res['files'] = [];
            if (null !== $this->files && \is_array($this->files)) {
                $n = 0;
                foreach ($this->files as $item) {
                    $res['files'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->participants) {
            $res['participants'] = [];
            if (null !== $this->participants && \is_array($this->participants)) {
                $n = 0;
                foreach ($this->participants as $item) {
                    $res['participants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ccs) {
            $res['ccs'] = [];
            if (null !== $this->ccs && \is_array($this->ccs)) {
                $n = 0;
                foreach ($this->ccs as $item) {
                    $res['ccs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sourceInfo) {
            $res['sourceInfo'] = null !== $this->sourceInfo ? $this->sourceInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessStartRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoStart'])) {
            $model->autoStart = $map['autoStart'];
        }
        if (isset($map['initiatorUserId'])) {
            $model->initiatorUserId = $map['initiatorUserId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['redirectUrl'])) {
            $model->redirectUrl = $map['redirectUrl'];
        }
        if (isset($map['files'])) {
            if (!empty($map['files'])) {
                $model->files = [];
                $n            = 0;
                foreach ($map['files'] as $item) {
                    $model->files[$n++] = null !== $item ? files::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['participants'])) {
            if (!empty($map['participants'])) {
                $model->participants = [];
                $n                   = 0;
                foreach ($map['participants'] as $item) {
                    $model->participants[$n++] = null !== $item ? participants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ccs'])) {
            if (!empty($map['ccs'])) {
                $model->ccs = [];
                $n          = 0;
                foreach ($map['ccs'] as $item) {
                    $model->ccs[$n++] = null !== $item ? ccs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sourceInfo'])) {
            $model->sourceInfo = sourceInfo::fromMap($map['sourceInfo']);
        }

        return $model;
    }
}
