<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs;
use AlibabaCloud\Tea\Model;

class CreateSectionConfigRequest extends Model
{
    /**
     * @description 扩展参数
     *
     * @var string
     */
    public $ext;

    /**
     * @description 课表模板信息
     *
     * @var sectionConfigs[]
     */
    public $sectionConfigs;

    /**
     * @description 操作人的userid。
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'ext'            => 'ext',
        'sectionConfigs' => 'sectionConfigs',
        'opUserId'       => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->sectionConfigs) {
            $res['sectionConfigs'] = [];
            if (null !== $this->sectionConfigs && \is_array($this->sectionConfigs)) {
                $n = 0;
                foreach ($this->sectionConfigs as $item) {
                    $res['sectionConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSectionConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['sectionConfigs'])) {
            if (!empty($map['sectionConfigs'])) {
                $model->sectionConfigs = [];
                $n                     = 0;
                foreach ($map['sectionConfigs'] as $item) {
                    $model->sectionConfigs[$n++] = null !== $item ? sectionConfigs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
