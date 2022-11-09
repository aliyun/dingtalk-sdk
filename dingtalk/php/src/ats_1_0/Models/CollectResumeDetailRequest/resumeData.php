<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\baseInfo;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\certificates;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\educationExperiences;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\jobExpect;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\languageSkill;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\trainingExperiences;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData\workExperiences;
use AlibabaCloud\Tea\Model;

class resumeData extends Model
{
    /**
     * @description 简历基础信息
     *
     * @var baseInfo
     */
    public $baseInfo;

    /**
     * @description 证书信息
     *
     * @var certificates[]
     */
    public $certificates;

    /**
     * @description 教育经历
     *
     * @var educationExperiences[]
     */
    public $educationExperiences;

    /**
     * @description 期望职位信息
     *
     * @var jobExpect
     */
    public $jobExpect;

    /**
     * @description 语言能力
     *
     * @var languageSkill[]
     */
    public $languageSkill;

    /**
     * @description 培训经历
     *
     * @var trainingExperiences[]
     */
    public $trainingExperiences;

    /**
     * @description 工作经历
     *
     * @var workExperiences[]
     */
    public $workExperiences;
    protected $_name = [
        'baseInfo'             => 'baseInfo',
        'certificates'         => 'certificates',
        'educationExperiences' => 'educationExperiences',
        'jobExpect'            => 'jobExpect',
        'languageSkill'        => 'languageSkill',
        'trainingExperiences'  => 'trainingExperiences',
        'workExperiences'      => 'workExperiences',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseInfo) {
            $res['baseInfo'] = null !== $this->baseInfo ? $this->baseInfo->toMap() : null;
        }
        if (null !== $this->certificates) {
            $res['certificates'] = [];
            if (null !== $this->certificates && \is_array($this->certificates)) {
                $n = 0;
                foreach ($this->certificates as $item) {
                    $res['certificates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->educationExperiences) {
            $res['educationExperiences'] = [];
            if (null !== $this->educationExperiences && \is_array($this->educationExperiences)) {
                $n = 0;
                foreach ($this->educationExperiences as $item) {
                    $res['educationExperiences'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->jobExpect) {
            $res['jobExpect'] = null !== $this->jobExpect ? $this->jobExpect->toMap() : null;
        }
        if (null !== $this->languageSkill) {
            $res['languageSkill'] = [];
            if (null !== $this->languageSkill && \is_array($this->languageSkill)) {
                $n = 0;
                foreach ($this->languageSkill as $item) {
                    $res['languageSkill'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->trainingExperiences) {
            $res['trainingExperiences'] = [];
            if (null !== $this->trainingExperiences && \is_array($this->trainingExperiences)) {
                $n = 0;
                foreach ($this->trainingExperiences as $item) {
                    $res['trainingExperiences'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workExperiences) {
            $res['workExperiences'] = [];
            if (null !== $this->workExperiences && \is_array($this->workExperiences)) {
                $n = 0;
                foreach ($this->workExperiences as $item) {
                    $res['workExperiences'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resumeData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseInfo'])) {
            $model->baseInfo = baseInfo::fromMap($map['baseInfo']);
        }
        if (isset($map['certificates'])) {
            if (!empty($map['certificates'])) {
                $model->certificates = [];
                $n                   = 0;
                foreach ($map['certificates'] as $item) {
                    $model->certificates[$n++] = null !== $item ? certificates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['educationExperiences'])) {
            if (!empty($map['educationExperiences'])) {
                $model->educationExperiences = [];
                $n                           = 0;
                foreach ($map['educationExperiences'] as $item) {
                    $model->educationExperiences[$n++] = null !== $item ? educationExperiences::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['jobExpect'])) {
            $model->jobExpect = jobExpect::fromMap($map['jobExpect']);
        }
        if (isset($map['languageSkill'])) {
            if (!empty($map['languageSkill'])) {
                $model->languageSkill = [];
                $n                    = 0;
                foreach ($map['languageSkill'] as $item) {
                    $model->languageSkill[$n++] = null !== $item ? languageSkill::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['trainingExperiences'])) {
            if (!empty($map['trainingExperiences'])) {
                $model->trainingExperiences = [];
                $n                          = 0;
                foreach ($map['trainingExperiences'] as $item) {
                    $model->trainingExperiences[$n++] = null !== $item ? trainingExperiences::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workExperiences'])) {
            if (!empty($map['workExperiences'])) {
                $model->workExperiences = [];
                $n                      = 0;
                foreach ($map['workExperiences'] as $item) {
                    $model->workExperiences[$n++] = null !== $item ? workExperiences::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
